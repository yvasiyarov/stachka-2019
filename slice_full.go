
//как эту функцию вызвал бы C# программист
slice := make([]int, 5, 5)
update_slice(slice)

func  update_slice([]int slice) {
   //все хорошо
  slice[0] = 5
  
  //и тут работает
  append(slice, []int{5, 2})

  //упс...
  append(slice, []int{1,2,3,4,5})
}
