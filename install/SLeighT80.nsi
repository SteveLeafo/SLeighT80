;--------------------------------
!include "MUI.nsh"
!include "LogicLib.nsh"
!include "x64.nsh"
!include "FileAssociation.nsh"
;--------------------------------

; The following variables are initialised in OnInit
Var SLeighT80SoftwareTitle
Var SLeighT80SoftwareInstallerExe
	

Name "SLeighT80"
OutFile "SLeighT80 - Setup.exe"
!define PRODUCT_DIR_REGKEY "Software\Microsoft\Windows\CurrentVersion\App Paths\SLeighT80"

;Default installation folder
InstallDir "$PROGRAMFILES64\SLeighT80"
InstallDirRegKey HKLM "${PRODUCT_DIR_REGKEY}" "Path"

;Set Compression Type
SetCompressor LZMA
;SetCompressor BZIP2
;SetCompressor ZLIB

BrandingText /TRIMCENTER "BudSoft Pty Ltd"

XPStyle on

VIAddVersionKey "ProductName" "SLeighT80 - The Winforms 8080 Emulator"
VIAddVersionKey "CompanyName" "BudSoft Software Pty Ltd"
VIAddVersionKey "LegalCopyright" "BudSoft Software Pty Ltd"
VIAddVersionKey "LegalTrademarks" ""
VIAddVersionKey "ProductVersion" "0.0.1.523"
VIAddVersionKey "FileVersion" "0.0.1.523"
VIAddVersionKey "FileDescription" "Installer for SLeighT80 - The Winforms 8080 Emulator"
VIAddVersionKey "Comments" ""
VIProductVersion "1.0.0.0"




;--------------------------------
;Interface Settings

!define MUI_ABORTWARNING
;!define MUI_HEADERIMAGE_BITMAP_NOSTRETCH
;!define MUI_HEADERIMAGE_BITMAP "..\Common\Images\deswik.logo.bmp"
;!define MUI_HEADERIMAGE
;!define MUI_WELCOMEFINISHPAGE_BITMAP "..\Common\Images\DeswikWizardSideBar.bmp"


!define MUI_WELCOMEPAGE_TITLE "Welcome to SLeighT80 - The Winforms 8080 Emulator"
!insertmacro MUI_PAGE_WELCOME
!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_INSTFILES
!define MUI_FINISHPAGE_TITLE "Completing SLeighT80 Installer"
!insertmacro MUI_PAGE_FINISH

;--------------------------------
;Macro creates functions to initialise variables in installer and uninstaller
!macro CommonInitVars UN
Function ${UN}InitVars
	StrCpy $SLeighT80SoftwareTitle "SLeighT80 - The Winforms 8080 Emulator"
	StrCpy $SLeighT80SoftwareInstallerExe "$SLeighT80SoftwareTitle.exe"
FunctionEnd
!macroend

!insertmacro CommonInitVars ""
!insertmacro CommonInitVars "un."

;--------------------------------
;Languages
!insertmacro MUI_LANGUAGE "English"

;--------------------------------
;Reserve Files
!insertmacro MUI_RESERVEFILE_INSTALLOPTIONS

;--------------------------------
;Installer Sections
InstType "Documentation Installation"
InstType /NOCUSTOM

;--------------------------------
;Installer Sections

Section "Full Installation" FullInstallation
SectionIn 1
        SetShellVarContext all
        ;Call DetectRunningApplications
        Call CheckUserIsAdministrator
        Call InstallSLeighT80Files
	Call CheckAndInstallDotNet
	Call InstallUninstaller
	Call InstallFileAssociations
	Call InstallApplicationShortcuts
	
SectionEnd

;--------------------------------
;Uninstaller Section

Section "Uninstall"
	;Call Un.DetectRunningApplications
  	Call Un.CheckUserIsAdministrator
	Call Un.InstallSLeighT80Files
	Call Un.InstallFileAssociations
	Call Un.InstallUninstaller
	Call Un.InstallApplicationShortcuts

SectionEnd



;******************************************************************************
; Creates shortcuts for the application
; Pre: $DeswikSoftwareSuite must be the name of the software suite
;      e.g. "Deswik Software Suite 1.3"
;******************************************************************************
Function InstallApplicationShortcuts
SetShellVarContext all
		
    RMDir /r "$SMPROGRAMS\SLeighT80"
  	

    CreateDirectory "$SMPROGRAMS\SLeighT80"
    SetOutPath "$SMPROGRAMS\SLeighT80"
    CreateShortCut "$SMPROGRAMS\SLeighT80\SLeighT80.lnk" "$INSTDIR\SLeighT80.exe" "" "$INSTDIR\SLeighT80.ico" 0

    ;IfFileExists "$INSTDIR\SLeighT80.exe" 0 +2
		   	      
FunctionEnd 

;******************************************************************************
; Deletes shortcuts for the application
;******************************************************************************
Function Un.InstallApplicationShortcuts
    SetShellVarContext all    
    RMDir /r "$SMPROGRAMS\SLeighT80"   
FunctionEnd


;******************************************************************************
; Sets up the registry entries needed to support Add/Remove programs
;******************************************************************************
Function InstallUninstaller 
    DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\SLeighT80"	

    WriteUninstaller "$INSTDIR\Uninstall $SLeighT80SoftwareInstallerExe"
    WriteRegStr HKLM "${PRODUCT_DIR_REGKEY}" "Path" "$INSTDIR"
    WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\$SLeighT80SoftwareTitle" "DisplayName" "$SLeighT80SoftwareTitle"
    WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\$SLeighT80SoftwareTitle" "UninstallString" "$INSTDIR\Uninstall $SLeighT80SoftwareInstallerExe"
    
    WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\$SLeighT80SoftwareTitle" "Publisher" "BudSoft"
  	
    WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\$SLeighT80SoftwareTitle" "DisplayVersion" "1.0.0.0"
  			
			
    WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\$SLeighT80SoftwareTitle" "NoModify" "1"
    WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\$SLeighT80SoftwareTitle" "NoRepair" "1"
FunctionEnd

;******************************************************************************
; Removes the registry entries needed to support Add/Remove programs
;******************************************************************************
Function Un.InstallUninstaller
	DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\$SLeighT80SoftwareTitle"
	DeleteRegKey HKLM "${PRODUCT_DIR_REGKEY}"
FunctionEnd


;******************************************************************************
; Initialisation callback installer (doesn't get run during uninstall - see un.onInit)
;******************************************************************************
Function .onInit
	Call InitVars
FunctionEnd

;******************************************************************************
; Initialisation callback for uninstaller
;******************************************************************************
Function un.onInit
	Call un.InitVars
FunctionEnd

;*********************************************************************
; Installs documentation files for the software suite
;*********************************************************************
Function InstallSLeighT80Files
	
    CreateDirectory "$INSTDIR"
	SetOutPath "$INSTDIR"
	File "..\SLeighT80\bin\Release\SLeighT80.exe"
	File "..\SLeighT80\SLeighT80.ico"
	File "..\SLeighT80\bin\Release\SharpDX.dll"
	File "..\SLeighT80\bin\Release\SharpDX.XInput.dll"
	File "0.wav"
	File "1.wav"
	File "2.wav"
	File "3.wav"
	File "4.wav"
	File "5.wav"
	File "6.wav"
	File "7.wav"
	File "8.wav"
	File "9.wav"

FunctionEnd

;*********************************************************************
; Uninstalls documentation files for the software suite
;*********************************************************************
Function Un.InstallSLeighT80Files
	SetShellVarContext all
	Delete "$INSTDIR\*.*"
	Delete "$INSTDIR\Users\*.*"
	
	RMDir "$INSTDIR\Users"
	RMDir "$INSTDIR"
FunctionEnd


;******************************************************************************
; Registers the file associations for files used by the installed applications
;******************************************************************************
Function InstallFileAssociations    
	; Register the Deswik CAD files
	${registerExtension} "$INSTDIR\SLeighT80.exe" ".rpx" "Wii-U Game Files"		
FunctionEnd

;******************************************************************************
; Unregisters the file associations for files used by the installed applications
;******************************************************************************
Function Un.InstallFileAssociations    
    ; Unregister the Deswik CAD files
    ${unregisterExtension} ".rpx" "Wii-U Game Files"	     
FunctionEnd


;******************************************************************************
; Checks for and installs .NET
;******************************************************************************
Function CheckAndInstallDotNet
    ; Magic numbers from http://msdn.microsoft.com/en-us/library/ee942965.aspx
    ClearErrors
    ReadRegDWORD $0 HKLM "SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full" "Release"

    IfErrors NotDetected

    ${If} $0 >= 378389
        DetailPrint "Microsoft .NET Framework 4.5 is installed ($0)"
    ${Else}
    NotDetected:
        DetailPrint "Installing Microsoft .NET Framework 4.5"
        SetDetailsPrint listonly
        ExecWait '"$INSTDIR\Tools\dotNetFx45_Full_setup.exe" /passive /norestart' $0
        ${If} $0 == 3010 
        ${OrIf} $0 == 1641
            DetailPrint "Microsoft .NET Framework 4.5 installer requested reboot"
            SetRebootFlag true
        ${EndIf}
        SetDetailsPrint lastused
        DetailPrint "Microsoft .NET Framework 4.5 installer returned $0"
    ${EndIf}

FunctionEnd


;******************************************************************************
; Aborts the installation if the user is not an administrator
; This code has been adapted from an example on the NSIS website.
;******************************************************************************
Function CheckUserIsAdministrator
    # call userInfo plugin to get user info.  The plugin puts the result in the stack
        userInfo::getAccountType

        # pop the result from the stack into $0
        pop $0

        # compare the result with the string "Admin" to see if the user is admin.
        # If match, jump 3 lines down.
        strCmp $0 "Admin" +3

        # if there is not a match, print message and return
    messageBox MB_OK "Please log in as an administrator of this computer to install this software."
    Abort
FunctionEnd

;******************************************************************************
; See Un.CheckUserIsAdministrator
;******************************************************************************
Function Un.CheckUserIsAdministrator
    # call userInfo plugin to get user info.  The plugin puts the result in the stack
        userInfo::getAccountType

        # pop the result from the stack into $0
        pop $0

        # compare the result with the string "Admin" to see if the user is admin.
        # If match, jump 3 lines down.
        strCmp $0 "Admin" +3

        # if there is not a match, print message and return
    messageBox MB_OK "Please log in as an administrator of this computer to uninstall this software."
    Abort
FunctionEnd
