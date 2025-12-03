{$mode objfpc}
var
  f: text;
  str: String;
begin
  {$I-}
  Assign(f, 'file.txt');
  Reset(f);
  {$I+}
  if IOResult <> 0 then
  begin
    Writeln('Error reading file!');
    Readln;
    Exit;
  end;
  Writeln('Reading from file:');
  while not (eof(f)) do
  begin
    Readln(f, str);
    Writeln(str);
  end;
  Readln;
end.