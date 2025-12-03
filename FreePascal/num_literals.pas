{$MODE OBJFPC}
{$COPERATORS ON}
{$LONGSTRINGS ON}
{$OPTIMIZATION ON}

const value = Cos(Pi / 3);
      text = 'Hello, World!';
      // text = Copy('Hello, World!', 1, 6);
begin
  Writeln(text);
  Writeln(value:0:4);
  Writeln(%101); // 2^2 + 1 = 5
  Writeln(&100); // 8^2 = 64
  Writeln($FF);  // 15 * 16^1 + 15 * 16^0 = 255
end.
