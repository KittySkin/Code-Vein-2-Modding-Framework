@echo off
setlocal EnableExtensions EnableDelayedExpansion

set "SRC=D:\CodeVein2Modding\UnpackedGameFiles 1.0.7\CodeVein2\Content\Blueprint\Article\BloodCode"
set "DST=D:\CodeVein2Modding\UnpackedGameFiles 1.0.9\CodeVein2\Content\Blueprint\Article\BloodCode"
set "LOG=%~dp0diff-log.txt"

> "%LOG%" (
    echo Source: %SRC%
    echo Dest:   %DST%
    echo.
)

echo Comparing files from SRC to DST...
for /r "%SRC%" %%F in (*) do (
    set "FULL=%%F"
    set "REL=!FULL:%SRC%\=!"
    set "OTHER=%DST%\!REL!"

    if exist "!OTHER!" (
        fc /b "%%F" "!OTHER!" >nul
        if errorlevel 1 (
            echo DIFF: !REL!
            >> "%LOG%" echo DIFF: !REL!
        ) else (
            echo MATCH: !REL!
            >> "%LOG%" echo MATCH: !REL!
        )
    ) else (
        echo MISSING_IN_DST: !REL!
        >> "%LOG%" echo MISSING_IN_DST: !REL!
    )
)

echo.
echo Checking for extra files in DST...
for /r "%DST%" %%F in (*) do (
    set "FULL=%%F"
    set "REL=!FULL:%DST%\=!"
    set "OTHER=%SRC%\!REL!"

    if not exist "!OTHER!" (
        echo EXTRA_IN_DST: !REL!
        >> "%LOG%" echo EXTRA_IN_DST: !REL!
    )
)

echo.
echo Done. Log written to: %LOG%
endlocal