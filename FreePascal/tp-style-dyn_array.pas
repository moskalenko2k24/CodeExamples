{$mode objfpc}
{$R+}
uses heaptrc;
type dyn_arr = array [1..MAXINT div sizeof(Integer)] of Integer;
	 pdyn_arr = ^dyn_arr;
var a: pdyn_arr;
	i, size: Integer;
begin
   Randomize;
   size := 10;
   getmem(a, sizeof(Integer) * size);
   for i := 1 to size do begin
      a^[i] := Random(15); Write(a^[i], ' ');
   end;
   Writeln;
   freemem(a, sizeof(Integer) * size);
   Writeln('OK');
end.
