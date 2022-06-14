using SharpDX.XInput;
using SLeighT80.Processors.i8080;

namespace SLeighT80.Machines.Invaders
{
    class Input
    {
        // The current controller state, helps to differentiate between keyboard and controllers
        private static ushort m_controllerState;

        // Set true if we are using the control stick to move left
        private static bool m_stickLeft;

        // Set true if we are using the control stick to move right
        private static bool m_stickRight;

        // Set true if we are using the control stick to move left
        private static bool m_stickUp;

        // Set true if we are using the control stick to move right
        private static bool m_stickDown;

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
                CheckXInputButtons(machine, state, GamepadButtonFlags.DPadUp, 0x80);
                CheckXInputButtons(machine, state, GamepadButtonFlags.DPadDown, 0x08);

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
                m_controllerState |= (ushort)flag;
            }
            else
            {
                if ((m_controllerState & (ushort)flag) != 0)
                {
                    machine.PORT_IN_1 = unchecked((byte)(machine.PORT_IN_1 & (byte)~portByte));
                    m_controllerState = unchecked((ushort)(m_controllerState & (ushort)~flag));
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
                m_stickRight = true;
            }
            else if (state.Gamepad.LeftThumbX < -Gamepad.LeftThumbDeadZone)
            {
                machine.PORT_IN_1 |= 0x20;
                m_stickLeft = true;
            }
            else if (state.Gamepad.LeftThumbY < -Gamepad.LeftThumbDeadZone)
            {
                machine.PORT_IN_1 |= 0x08;
                m_stickDown = true;
            }
            else if (state.Gamepad.LeftThumbY > Gamepad.LeftThumbDeadZone)
            {
                machine.PORT_IN_1 |= 0x80;
                m_stickUp = true;
            }
            else
            {
                if (m_stickRight)
                {
                    machine.PORT_IN_1 = unchecked((byte)(machine.PORT_IN_1 & (byte)~0x40));
                    m_stickRight = false;
                }
                else if (m_stickLeft)
                {
                    machine.PORT_IN_1 = unchecked((byte)(machine.PORT_IN_1 & (byte)~0x20));
                    m_stickLeft = false;
                }
                else if (m_stickUp)
                {
                    machine.PORT_IN_1 = unchecked((byte)(machine.PORT_IN_1 & (byte)~0x80));
                    m_stickUp = false;
                }
                else if (m_stickDown)
                {
                    machine.PORT_IN_1 = unchecked((byte)(machine.PORT_IN_1 & (byte)~0x08));
                    m_stickDown = false;
                }
            }
        }
    }
}
