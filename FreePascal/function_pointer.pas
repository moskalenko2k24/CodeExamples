{$mode objfpc}
type
  func = function(const a, b: Integer): Integer;

function sum(const a, b: Integer): Integer;
begin
  Result := a + b; 
end;

function mult(const a, b: Integer): Integer;
begin
  Result := a * b; 
end;


function calc(const a, b: Integer; const f: func): Integer;
begin
  Result := f(a, b); 
end;

var
  x, y: Integer;
begin
  x := 3;
  y := 4;
  Writeln('x + y = ', calc(x, y, @sum)); // 7
  Writeln('x * y = ', calc(x, y, @mult)); // 12
  // Readln;
end.