{$mode objfpc}
type
  counter = class
  private 
    count: Integer;
  public 
    constructor Create;
    constructor Create(const a: Integer);
    function getcount: Integer;
    procedure inc;
    procedure dec;
  end;

constructor counter.Create;
begin
  inherited Create;
  count := 0;
end;

constructor counter.Create(const a: Integer);
begin
  inherited Create;
  count := a;
end;

function counter.getcount: Integer;
begin
  Result := count;
end;

procedure counter.inc;
begin
  System.inc(count);
end;

procedure counter.dec;
begin
  System.dec(count);
end;

var
  a, b: counter;
begin
  a := counter.Create;
  b := counter.Create(4);
  Writeln('a = ', a.getcount); // 0
  Writeln('b = ', b.getcount); // 4
  a.Free; b.Free;
  //Readln;
end.