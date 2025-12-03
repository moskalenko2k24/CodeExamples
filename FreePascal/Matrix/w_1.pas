const MAX_SIZE = 100;
var a:array[1..MAX_SIZE, 1..MAX_SIZE] of Integer;
	i, j, n: Integer;
begin
   Readln(n);
   
   for i := 1 to n do
     if i < n div 2 + 1 then 
	   for j := i to n - i + 1 do a[i, j] := 1 else
     if i = n div 2 + 1 then a[i, n div 2 + 1] := 1 else 
       for j:=1 to n do a[i, j] := a[n - i + 1, j];
	   
   for i := 1 to n do begin
      for j := 1 to n do Write(a[i, j]:4);
	  Writeln;
   end;
   Readln;
end.