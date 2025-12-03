{$mode objfpc}
{  program.exe -n -k 
   Input:
   a1 a2 a3 ... an
   b1 b2 b3 ... bn
   Output:
   b1+k*a1 b2+k*a2 ... bn+k*an
}
uses SysUtils;
var i, n, t, k: Integer;
    a: array of Integer;
begin
  n := StrToInt(ParamStr(1));
  if ParamCount > 1 then k := StrToInt(ParamStr(2)) 
  else k := 1;
  SetLength(a, n);
  for i := 0 to n - 1 do Read(a[i]);
  for i := 0 to n - 1 do 
   begin
    Read(t);
    Write(t + k * a[i], ' ');
   end;
end.