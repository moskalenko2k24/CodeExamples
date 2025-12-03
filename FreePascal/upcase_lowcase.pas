function MyUpCase(s: String):String;
var i: Integer;
begin
  for i := 1 to Length(s) do 
   case s[i] of
	'à'..'ï': s[i] := Chr(Ord('À') + Ord(s[i]) - Ord('à'));
	'ð'..'ÿ': s[i] := Chr(Ord('Ð') + Ord(s[i]) - Ord('ð'));
	'a'..'z': s[i] := Chr(Ord('A') + Ord(s[i]) - Ord('a'));
	'¸': s[i] := '¨';
   end;
  MyUpCase := s;
end;

function MyLowCase(s: String):String;
var i: Integer;
begin
  for i := 1 to Length(s) do 
	case s[i] of
	 'À'..'Ï': s[i] := Chr(Ord('à') + Ord(s[i]) - Ord('À'));
	 'Ð'..'ß': s[i] := Chr(Ord('ð') + Ord(s[i]) - Ord('Ð'));
	 'A'..'Z': s[i] := Chr(Ord('a') + Ord(s[i]) - Ord('A'));
     '¨': s[i] := '¸';
    end;
  MyLowCase := s;
end;

begin
end.