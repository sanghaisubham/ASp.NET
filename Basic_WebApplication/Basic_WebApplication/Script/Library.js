﻿function Leap(year)
{
    if (year % 4 == 0) {
        if ((year % 100 != 0) || (year % 400 == 0))
            return true;
        else
            return false;
    }
    else
        return false;
}
function GetCurrentDate()
{
    return (new Date()).toDateString();
}