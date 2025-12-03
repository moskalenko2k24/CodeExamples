{$MODE OBJFPC}
{$COPERATORS ON}
{$LONGSTRINGS ON}
{$OPTIMIZATION ON}
uses Crt;
var i, j, n, k, m: Integer;
begin
  ClrScr;
  Write('n = ');
  Readln(n);
  n += Ord(n mod 2 = 0);
  k := n div 2 + 1;
  for i := 1 to n do begin
    m := i;
    if m > k then m := k - (i - k);
    for j := 1 to k - m do Write(' ');
    Write('*');
    if (i = 1) or (i = n) then begin
      Writeln;
      Continue;
    end;
    for j := 1 to n - 2 * (k - m) - 2 do Write(' ');
    Writeln('*');
  end;
end.
{
1    *
2   * *
3  *   *
4 *     *
5  *   *
6   * *
7    *
}
