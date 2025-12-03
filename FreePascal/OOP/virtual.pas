{$mode objfpc}
type
  Shape = class
  public 
    procedure Draw; virtual;
  end;

type
  Circle = class(Shape)
  public 
    procedure Draw; override;
  end;

type
  Triangle = class(Shape)
  public 
    procedure Draw; override;
  end;

type
  RightTriangle = class(Triangle)
  public 
    procedure Draw; override;
  end;

procedure Shape.Draw;
begin
  Writeln('Shape.Draw');
end;

procedure Circle.Draw;
begin
  Writeln('Circle.Draw');
end;

procedure Triangle.Draw;
begin
  Writeln('Triangle.Draw');
end;

procedure RightTriangle.Draw;
begin
  Writeln('RightTriangle.Draw');
end;

var
  a, b, c, d: Shape;

begin
  a := Shape.Create;
  b := Circle.Create;
  c := Triangle.Create;
  d := RightTriangle.Create;
  a.Draw; // Shape.Draw
  b.Draw; // Circle.Draw
  c.Draw; // Triangle.Draw
  d.Draw; // RightTriangle.Draw
  //Without virtual Shape.Draw for all
  a.Free; b.Free ;c.Free ;d.Free;
  //Readln;
end.