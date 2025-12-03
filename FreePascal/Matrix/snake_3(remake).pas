//Заполнение матрицы змейкой по диагоналям
var a:array[1..100,1..100] of Integer;
i,j,n,t,x,y:Integer;
begin
Write('n=');
Readln(n);
a[1,1]:=1;
t:=1;
for i:=2 to n do
 begin
  if not(odd(i)) then 
   begin
    y:=i+1;
    x:=0;
    while y<>1 do
     begin
      inc(t);
      dec(y);
      inc(x);
      a[y,x]:=t;
     end; 
   end else
   begin
    y:=0;
    x:=i+1;
    while y<>i do
     begin
     inc(t);
     inc(y);
     dec(x);
     a[y,x]:=t;
     end;
   end;
 end;
 
 for i:=2 to n-1 do
  begin
   if ((i mod 2=0) and (n mod 2=1)) or ((i mod 2=1) and (n mod 2=0)) then
    begin
     y:=n+1;
     x:=i-1;
      while x<>n do
       begin
        inc(t);
        dec(y);
        inc(x);
        a[y,x]:=t;
       end;
    end else
    begin
     y:=i-1;
     x:=n+1;
      while y<>n do
       begin
        inc(t);
        inc(y);
        dec(x);
        a[y,x]:=t;
       end;
    end;
  end;
a[n,n]:=n*n;
for i:=1 to n do
 begin
  for j:=1 to n do Write(a[i][j]:4);
  Writeln;
 end;
Readln;
end.
