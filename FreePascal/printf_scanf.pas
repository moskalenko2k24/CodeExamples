{$mode objfpc}

procedure printf(fm: pchar;args: array of const); cdecl; external 'c';  
procedure scanf(fm: pchar;args: array of const); cdecl; external 'c';  

var a, b: Integer;
begin
  scanf('%d %d', [@a, @b]);
  printf('%d', [a + b]);
end.
