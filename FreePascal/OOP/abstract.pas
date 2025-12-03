{$mode objfpc}
type
  Shape = class
  public 
    procedure Draw; virtual; abstract;
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
   a := Shape.Create;//Warning: Constructing a class "Shape" with abstract method "Draw"
   b := Circle.Create;
   c := Triangle.Create;
   d := RightTriangle.Create;
   // a.Draw will be RunTime Error
   b.Draw; // Circle.Draw
   c.Draw; // Triangle.Draw
   d.Draw; // RightTriangle.Draw
   a.Free; b.Free; c.Free; d.Free;
   //Readln;
end.