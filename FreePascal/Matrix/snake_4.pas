const MAX_SIZE = 100;

function _inc(var x: Integer): Integer;
begin x := x + 1; _inc := x; end;
 
var a: array[1..MAX_SIZE, 1..MAX_SIZE] of Integer;
	i, j, n, x: Integer;
begin
   Readln(n);
   x := 0;
   for i := 1 to n div 2 + Ord(odd(n)) do begin
 
      for j := i to n - i + 1 do 
         a[i, j] := _inc(x);
 
	  for j := i + 1 to n - i + 1 do
	     a[j, n - i + 1] := _inc(x);
 
	  for j := n - i downto i do
	     a[n - i + 1, j] := _inc(x);
 
	  for j := n - i downto i + 1 do
	     a[j, i] := _inc(x);
 
   end;
   for i := 1 to n do begin
      for j := 1 to n do Write(a[i, j]:4);
	  Writeln;
   end;
end.