var
  f: file of Integer;
  i: Integer;
begin
  Assign(f, 'int.dat'); Rewrite(f);
  Writeln('Writting to file:');
  for i := 0 to 9 do begin
    Write(f, i);
    Write(i, ' ');
  end;
  Reset(f); Writeln('Reading from file:');
  while not (eof(f)) do
  begin
    Read(f, i);
    Write(i, ' ');
  end;
  Close(f);
  Writeln;
  Readln;
end.