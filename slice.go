func update_slice(slice []int) {
    //все хорошо
    slice[0] = 100

    //а вот эти изменения мы потеряем...
    slice = append(slice, 1,2)
}

func main() {
    slice := make([]int, 1, 5)
	
    //как эту функцию вызвал бы C# программист
    update_slice(slice)
    fmt.Printf("Slice: %v \n", slice)
}
