{$mode delphi}
//uses heaptrc;
type TPair<TFirst, TSecond> = class
     public
       first: TFirst;
       second: TSecond;
       constructor Create(a:TFirst=Default(TFirst); b:TSecond=Default(TSecond));
       procedure print;
     end;

constructor TPair<TFirst, TSecond>.Create(a:TFirst = Default(TFirst); b:TSecond = Default(TSecond));
begin
  first := a; second := b;
end;

procedure TPair<TFirst, TSecond>.print;
begin
  Writeln(first,' ',second);
end;

var p: TPair<Integer, String>;
begin
  p := TPair<Integer, String>.Create(123, 'lol');
  p.print;
  Writeln('-------------------');
  p.Free;
end.