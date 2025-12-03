uses
  contnrs;

var
  st: TStack;
  n, i: Integer;
  p: ^Integer;

begin
  Randomize;
  st := TStack.Create;
  Write('Count of numbers:');
  ReadLn(n);
  Writeln('Nubmers:');
  for i := 1 to n do
  begin
    new(p);
    p^ := Random(51) - 25;
    Write(p^, ' ');
    st.Push(p);
  end;
  WriteLn;
  Writeln('Stack:');
  while st.AtLeast(1) do
  begin
    p := st.Pop();
    Write(p^, ' ');
    dispose(p);
  end;
  Writeln;
  st.Free();
  Readln;
end.