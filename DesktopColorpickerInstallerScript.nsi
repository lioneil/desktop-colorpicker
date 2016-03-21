; Desktop Colorpicker Installer Script
; Version 1.0.0.2
;--------------------------------

  !include "MUI2.nsh"

;-------------------

; The name of the installer
Name "Desktop Colorpicker"

; The file to write
OutFile "desktop-colorpicker_installer_v2.0.0.0.exe"

; The default installation directory
InstallDir "$PROGRAMFILES\Desktop Colorpicker"

; Registry key to check for directory (so if you install again, it will
; overwrite the old one automatically)
InstallDirRegKey HKLM "Software\DesktopColorpicker" "Install_Dir"

; Request application privileges for Windows Vista
RequestExecutionLevel admin

;--------------------------------
;Interface Settings

  !define MUI_ABORTWARNING

  !define MUI_ICON "assets\colorpicker.ico"

  !define MUI_UNICON "assets\colorpicker.ico"

  !define MUI_BGCOLOR F0F0F0

  !define MUI_WELCOMEFINISHPAGE_BITMAP "assets\desktop-colorpicker-banner.bmp"

  !define MUI_UNWELCOMEFINISHPAGE_BITMAP "assets\desktop-colorpicker-banner.bmp"

;--------------------------------
;Pages

  !insertmacro MUI_PAGE_WELCOME
  !insertmacro MUI_PAGE_LICENSE "LICENSE"
  !insertmacro MUI_PAGE_COMPONENTS
  !insertmacro MUI_PAGE_DIRECTORY
  !insertmacro MUI_PAGE_INSTFILES
  !insertmacro MUI_PAGE_FINISH

  !insertmacro MUI_UNPAGE_WELCOME
  !insertmacro MUI_UNPAGE_CONFIRM
  !insertmacro MUI_UNPAGE_INSTFILES
  ;!insertmacro MUI_UNPAGE_FINISH


;Page components
;Page directory
;Page instfiles

;UninstPage uninstConfirm
;UninstPage instfiles

;--------------------------------
;Languages

  !insertmacro MUI_LANGUAGE "English"


;------------------------
; The stuff to install


; other requirements

Section "Desktop Colorpicker (required)"

  SectionIn RO

  ; Set output path to the installation directory.
  SetOutPath $INSTDIR

  ; Put file there
  File "_src\v2.0.0.2\DesktopColorpicker.exe"

  File "_src\v2.0.0.2\DesktopColorpicker.exe.config"

  File "_src\v2.0.0.2\DesktopColorpicker.exe.manifest"

  File "_src\v2.0.0.2\ColorPicker.dll"

  File "_src\v2.0.0.2\Unity3.Eyedropper.dll"

  File "assets\colorpicker.ico"

  ; Write the installation path into the registry
  WriteRegStr HKLM SOFTWARE\DesktopColorpicker "Install_Dir" "$INSTDIR"

  ; Write the uninstall keys for Windows
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\DesktopColorpicker" "DisplayName" "Desktop Colorpicker"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\DesktopColorpicker" "UninstallString" '"$INSTDIR\uninstall.exe"'
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\DesktopColorpicker" "NoModify" 1
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\DesktopColorpicker" "NoRepair" 1
  WriteUninstaller "uninstall.exe"

SectionEnd


Section "Resources (required)"

  SectionIn RO

  SetOutPath $INSTDIR
  File "LICENSE"

  SetOutPath $INSTDIR
  File "_src\v2.0.0.2\Microsoft.VisualBasic.PowerPacks.Vs.dll"

SectionEnd

; Optional section (can be disabled by the user)
Section "Start Menu Shortcuts"

  CreateDirectory "$SMPROGRAMS\Desktop Colorpicker"
  CreateShortcut "$SMPROGRAMS\Desktop Colorpicker\Uninstall.lnk" "$INSTDIR\uninstall.exe" "" "$INSTDIR\uninstall.exe" 0
  CreateShortcut "$SMPROGRAMS\Desktop Colorpicker\Desktop Colorpicker (shortcut).lnk" "$INSTDIR\DesktopColorpicker.exe" "" "$INSTDIR\DesktopColorpicker.exe" 0

SectionEnd

;DESKTOP SHORTCUT
Section "Create Desktop Shortcut"

  CreateShortcut "$DESKTOP\Desktop Colorpicker.lnk" "$INSTDIR\DesktopColorpicker.exe" "" "$INSTDIR\DesktopColorpicker.exe" 0

SectionEnd
;--------------------------------

; Uninstaller

Section "Uninstall"

  ; Remove registry keys
  DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Desktop Colorpicker"
  DeleteRegKey HKCU "Software\Microsoft\Windows\CurrentVersion\Run\Desktop Colorpicker"
  DeleteRegKey HKLM "SOFTWARE\Desktop Colorpicker"

  ; Remove files and uninstaller
  Delete $INSTDIR\DesktopColorpicker.exe
  Delete $INSTDIR\colorpicker.ico
  Delete $INSTDIR\Microsoft.VisualBasic.PowerPacks.Vs.dll
  Delete $INSTDIR\DesktopColorpicker.exe.config
  Delete $INSTDIR\DesktopColorpicker.exe.manifest
  Delete $INSTDIR\LICENSE
  Delete $INSTDIR\ColorPicker.dll
  Delete $INSTDIR\Unity3.Eyedropper.dll
  Delete $INSTDIR\uninstall.exe

  ; Remove shortcuts, if any
  Delete "$SMPROGRAMS\Desktop Colorpicker\*.*"
  Delete "$DESKTOP\Desktop Colorpicker.lnk"

  ; Remove directories used
  RMDir "$SMPROGRAMS\Desktop Colorpicker"
  RMDir "$INSTDIR"

SectionEnd
