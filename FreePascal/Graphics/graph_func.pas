uses
  Graph, WinCRT, SysUtils;

function f(const x: Real): Real;
begin
  f := cos(x);
end;

function g(const x: Real): Real;
begin
  g := sin(x);
end;

var
  x, y, d: Integer;
  gd, gm, i: Integer;
  a, b, dx: Real;

begin
  gd := Detect;
  InitGraph(gd, gm, '');
  SetColor(White);
  x := GetMaxX div 2;
  y := GetMaxY div 2;
  d := 0;
  MoveTo(x, y);
  OutTextXY(x + 2, y + 2, '0');
  for i := 1 to 9 do 
  begin
    inc(d, 55);
    Line(x, y, x + d, y); Line(x + d, y - 2, x + d, y + 2); OutTextXY(x + d, y + 3, IntToStr(i)); // OX, x > 0
    Line(x, y, x - d, y); Line(x - d, y - 2, x - d, y + 2); OutTextXY(x - d, y + 3, IntToStr(-i)); // OX, x < 0
    Line(x, y, x, y + d); Line(x - 2, y + d, x + 2, y + d); OutTextXY(x + 4, y + d, IntToStr(-i)); // OY, y < 0
    Line(x, y, x, y - d); Line(x - 2, y - d, x + 2, y - d); OutTextXY(x + 4, y - d, IntToStr(i)); // OY, y > 0
  end;
  a := -2 * pi; // [a; b]
  b := 2 * pi;
  dx := 0.005; // delta x
  while a <= b do
  begin
    a := a + dx;
    PutPixel(x + Round(a * 55), y - Round(f(a) * 55), Blue);
    PutPixel(x + Round(a * 55), y - Round(g(a) * 55), Red);
  end;
  ReadKey;
  CloseGraph;
end.
