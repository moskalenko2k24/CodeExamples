{$mode objfpc}
var
  a: array of Integer;
  i, p: Integer;
  ptr: ^Integer;
begin
   SetLength(a, 10);
   p := 1;
   for i := Low(a) to High(a) do begin
      a[i] := p; p := p * 2;
   end;
   ptr := @a[0];
   Writeln('Print using pointers:');
   while ptr <> @a[Length(a)] do begin
      Write(ptr^, ' ');
      ptr += 1;
   end;
end.