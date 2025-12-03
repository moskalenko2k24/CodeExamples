{$mode objfpc}
var
  f: text;
  str: String;
begin
  try
    Assign(f, 'file.txt');
    Reset(f);
    Writeln('Reading from file:');
    while not (eof(f)) do begin
      Readln(f, str);
      Writeln(str);
    end;
  except
    Writeln('Error reading file!');
  end;
  Readln;
end.