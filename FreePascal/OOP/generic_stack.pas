{$mode delphi}
//uses heaptrc;
 
type TStack<T> = class(TObject)
private
  arr:array of T;
  size_:Integer;
public
  constructor Create;
  procedure push(const value: T);
  procedure pop;
  function top: T;
  function size: Integer;
  function empty: Boolean;
end;
 
constructor TStack<T>.Create;
begin
  size_ := 0;
end;
 
procedure TStack<T>.push(const value: T);
begin
  if size_ = 0 then SetLength(arr, 1);
  if size_ = Length(arr) then SetLength(arr, size_ * 2);
  size_ := size_ + 1;
  arr[size_ - 1] := value;
end;
 
procedure TStack<T>.pop;
begin
  if size_ = 0 then Exit;
  size_ := size_ - 1;
end;
 
function TStack<T>.top: T;
begin
  if size_ = 0 then Exit;
  Result := arr[size_ - 1];
end;
 
function TStack<T>.size: Integer;
begin
  Result := size_;
end;
 
function TStack<T>.empty: Boolean;
begin
  Result := size_ = 0;
end;
 
var st: TStack<Integer>;
begin
  st := TStack<Integer>.Create;
  st.push(20); st.push(30); st.push(78); st.push(47);
  while not(st.empty) do
   begin
     Writeln(st.top); // 47 78 30 20
     st.pop;
   end;
  st.Free;
end.