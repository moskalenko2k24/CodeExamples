uses
  Graph, WinCrt;

const
  m = 0.05;

procedure DrawRect(const a1, b1, a2, b2, a3, b3, a4, b4: Real);
begin
  Line(Round(a1), Round(b1), Round(a2), Round(b2));
  Line(Round(a2), Round(b2), Round(a3), Round(b3));
  Line(Round(a3), Round(b3), Round(a4), Round(b4));
  Line(Round(a4), Round(b4), Round(a1), Round(b1));
end;

procedure Quadr(const x1, y1, x2, y2, x3, y3, x4, y4: Real; const n: Integer);
var
  a1, b1, a2, b2, a3, b3, a4, b4: Real;
begin
  if n = 0 then Exit;
  a1 := (x1 + m * x2) / (1 + m); b1 := (y1 + m * y2) / (1 + m);
  a2 := (x2 + m * x3) / (1 + m); b2 := (y2 + m * y3) / (1 + m);
  a3 := (x3 + m * x4) / (1 + m); b3 := (y3 + m * y4) / (1 + m);
  a4 := (x4 + m * x1) / (1 + m); b4 := (y4 + m * y1) / (1 + m);
  DrawRect(a1, b1, a2, b2, a3, b3, a4, b4);
  Quadr(a1, b1, a2, b2, a3, b3, a4, b4, n - 1);
end;

var
  x1, y1, x2, y2, x3, y3, x4, y4: Real;
  gd, gm: Integer;

begin
  gd := Detect;
  InitGraph(gd, gm, '');
  
  x1 := 20; y1 := x1;
  x2 := 900; y2 := y1;
  x3 := x2; y3 := x2;
  x4 := x1; y4 := y3;
  
  DrawRect(x1, y1, x2, y2, x3, y3, x4, y4);
  Quadr(x1, y1, x2, y2, x3, y3, x4, y4, 40);
  
  ReadKey;
  CloseGraph;
end.
