const MAX_SIZE = 100;
var a, b: array[1..MAX_SIZE, 1..MAX_SIZE] of Integer;
	i, j, n, m: Integer;
begin
   Read(n, m);
   Randomize;
   for i := 1 to n do begin
      for j := 1 to m do begin
         a[i, j] := Random(31);
         Write(a[i, j]:4);
      end;
      Writeln;
   end;
   Writeln('---------------------------------');
   for i := 1 to n do
     for j := 1 to m do 
        b[j, n - i + 1] := a[i, j]; 
    for i := 1 to m do begin
       for j := 1 to n do Write(b[i, j]:4);
       Writeln;
    end;
    //Readln;
end.