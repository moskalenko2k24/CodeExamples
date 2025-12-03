{$mode objfpc}
uses SysUtils;
type Student = record
     fio: String;
     marks: array[1..3] of Integer;
     end;
   
function isDigit(const c: Char): Boolean;
begin
  Result := c in ['0'..'9'];
end;

procedure ReadStudent(var f: Text; var obj: Student);
var s, mark: String;
    i, j: Integer;
begin
  Readln(f, s);
  s := s + ' ';
  i := 1; j := 0; mark := '';
  while not(isDigit(s[i])) do i += 1;
  obj.fio := Copy(s, 1, i - 1);
  while i <= Length(s) do begin
    if isDigit(s[i]) then mark += s[i] else
     if mark <> '' then
      begin
        j += 1;
        obj.marks[j] := StrToInt(mark);
        mark := ''; 
      end;
    i += 1;
  end;
end;     

procedure WriteStudent(const obj: Student);
var i: Integer;
begin
  Write(obj.fio);
  for i := 1 to 3 do Write(obj.marks[i], ' ');
  Writeln;
end;

function is_Excellent(const obj: Student): Boolean;
begin
  Result := (obj.marks[1] = 5) and (obj.marks[2] = 5) and (obj.marks[3] = 5);
end;
    
var t: Student;
    f: Text;
begin
  Assign(f, 'file4_txt.txt');
  Reset(f);
  while not(eof(f)) do begin
    ReadStudent(f, t);
    if is_Excellent(t) then WriteStudent(t);
  end;
  Close(f);
  Readln;
end.
