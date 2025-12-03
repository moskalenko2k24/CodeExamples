uses SysUtils;
begin
  Writeln(FormatDateTime('hh:nn dd/mm/yyyy', Now));
  Writeln('Type Enter to exit.');
  Readln;
end.