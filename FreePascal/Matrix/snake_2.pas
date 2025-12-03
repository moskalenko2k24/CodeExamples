const MAX_SIZE = 100;
var a: array[1..MAX_SIZE, 1..MAX_SIZE] of Integer;
	i, j, n, m: Integer;
begin
   Readln(n, m);
   for i := 1 to n do
      for j := 1 to m do
	     if odd(j) then a[i, j]:= n * (j - 1) + i 
		 else a[i, j] := n * (j - 1) + n - i + 1;
   for i := 1 to n do begin
      for j := 1 to m do Write(a[i, j]:4); 
	  Writeln;
   end;
end.