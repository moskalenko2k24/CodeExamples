uses Math;

procedure Print(a : array of Integer);
var i: Integer;
begin
  for i := 0 to Length(a)-1 do
    Write(a[i] : 3)
end;

var
  a: array of Integer;
  i: Integer;
begin
  SetLength(a, 10);
  for i := 0 to 9 do
    a[i] := RandomRange(-10, +10+1);
  for i := 0 to 9 do
    Write(a[i] : 3);
  WriteLn;
  Print(a[0..5]);
  Print(a[6..9]);
end.