﻿using SharpDX.XInput;
using SLeighT80.Processors.i8080;

namespace SLeighT80.Machines.Invaders
{
    class Input
    {
        // The current controller state, helps to differentiate between keyboard and controllers
        private static ushort controllerState = 0x0000;

        // Set true if we are using the control stick to move left
        private static bool stickLeft = false;

        // Set true if we are using the control stick to move right
        private static bool stickRight = false;
        
        // This will send values to the Input port in response to controller actions
        public static void Check(i8080 machine)
        {
            State state;
            if (machine.controller.GetState(out state))
            {
                CheckXInputButtons(machine, state, GamepadButtonFlags.Back, 0x01);
                CheckXInputButtons(machine, state, GamepadButtonFlags.Start, 0x04);
                CheckXInputButtons(machine, state, GamepadButtonFlags.A, 0x10);
                CheckXInputButtons(machine, state, GamepadButtonFlags.DPadLeft, 0x20);
                CheckXInputButtons(machine, state, GamepadButtonFlags.DPadRight, 0x40);

                CheckXInputSticks(machine, state);
            }
        }

        /// <summary>
        /// Checks the controllers buttons, Inputs set by a controller will be cleared if they are no longer active
        /// </summary>
        /// <param name="machine"></param>
        /// <param name="state"></param>
        /// <param name="flag"></param>
        /// <param name="portByte"></param>
        private static void CheckXInputButtons(i8080 machine, State state, GamepadButtonFlags flag, byte portByte)
        {
            if ((state.Gamepad.Buttons & flag) != 0)
            {
                machine.PORT_IN_1 |= portByte;
                controllerState |= (ushort)flag;
            }
            else
            {
                if ((controllerState & (ushort)flag) != 0)
                {
                    machine.PORT_IN_1 = unchecked((byte)(machine.PORT_IN_1 & (byte)~portByte));
                    controllerState = unchecked((ushort)(controllerState & (ushort)~flag));
                }
            }
        }

        /// <summary>
        /// Checks the controllers left stick, Inputs set by a controller will be cleared if they are no longer active
        /// </summary>
        /// <param name="machine"></param>
        /// <param name="state"></param>
        private static void CheckXInputSticks(i8080 machine, State state)
        {
            if (state.Gamepad.LeftThumbX > Gamepad.LeftThumbDeadZone)
            {
                machine.PORT_IN_1 |= 0x40;
                stickRight = true;
            }
            else if (state.Gamepad.LeftThumbX < -Gamepad.LeftThumbDeadZone)
            {
                machine.PORT_IN_1 |= 0x20;
                stickLeft = true;
            }
            else
            {
                if (stickRight)
                {
                    machine.PORT_IN_1 = unchecked((byte)(machine.PORT_IN_1 & (byte)~0x40));
                    stickRight = false;
                }
                else if (stickLeft)
                {
                    machine.PORT_IN_1 = unchecked((byte)(machine.PORT_IN_1 & (byte)~0x20));
                    stickLeft = false;
                }
            }
        }
    }
}
