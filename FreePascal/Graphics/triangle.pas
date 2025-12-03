uses
  Graph, WinCRT;

procedure MLine(x1, y1, x2, y2: Real);
begin
  Line(Round(x1), Round(y1), Round(x2), Round(y2));
end;

procedure Tr(const x1, y1, x2, y2, x3, y3: Real; k, n: Integer);
var
  a1, b1, a2, b2, a3, b3: Real;
begin
  if k = n then Exit;
  a1 := (x1 + x2) / 2;
  b1 := (y1 + y2) / 2;
  a2 := (x1 + x3) / 2;
  b2 := (y1 + y3) / 2;
  a3 := (x2 + x3) / 2;
  b3 := (y2 + y3) / 2;
  MLine(a1, b1, a2, b2);
  MLine(a1, b1, a3, b3);
  MLine(a2, b2, a3, b3);
  k := k + 1;
  Tr(x2, y2, a1, b1, a3, b3, k, n);
  Tr(x1, y1, a1, b1, a2, b2, k, n);
  Tr(x3, y3, a3, b3, a2, b2, k, n);
end;


var
  gd, gm: Integer;
  x1, y1, x2, y2, x3, y3, a: Real;

begin
  gd := Detect;
  InitGraph(gd, gm, '');
  x1 := 500; y1 := 100;
  a := 600;
  x2 := x1 - a / 2; y2 := y1 + a * sqrt(3) / 2;
  x3 := x1 + a / 2; y3 := y2;
  SetLineStyle(0, 0, NormWidth);
  MLine(x1, y1, x2, y2);
  MLine(x1, y1, x3, y3);
  MLine(x2, y2, x3, y3);
  Tr(x1, y1, x2, y2, x3, y3, 0, 5);
  ReadKey;
  CloseGraph;
end.
