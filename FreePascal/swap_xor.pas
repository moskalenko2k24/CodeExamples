var a, b: Byte;
begin
  a := 200; b := 100;
  Writeln('a = ', a, ' ; b = ', b);
  a := a xor b; 
  b := b xor a;
  a := a xor b; 
  Writeln('a = ', a, ' ; b = ', b);
end.