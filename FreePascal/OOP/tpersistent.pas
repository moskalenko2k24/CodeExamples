{$mode objfpc}
uses
  Classes;

type
  TPoint = class(TPersistent)
  private 
    x, y: Integer;
  public 
    constructor Create(a: Integer = 0; b: Integer = 0);
    procedure print;
    procedure Assign(Source: TPersistent); override;
  end;

constructor TPoint.Create(a: Integer = 0; b: Integer = 0);
begin
  x := a; y := b;
end;

procedure TPoint.print;
begin
  Writeln(x, ' ; ', y);
end;

procedure TPoint.Assign(Source: TPersistent);
begin
  x := (Source as TPoint).x;
  y := (Source as TPoint).y;
end;

var
  a, b: TPoint;

begin
  a := TPoint.Create(3, 5);
  a.print;
  b := TPoint.Create;
  b.Assign(a);
  b.print;
  a.Free;  b.Free;
end.