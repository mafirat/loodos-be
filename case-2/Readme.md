# n stack in a single array

Tek bir dizi içerisinde, 3 tane stack tutmak isterseniz, bunu nasıl yaparsınız?

> Bir diziyle 3 ya da n adet stack kullanımı için 
> * bir obje dizisi - arr
> * bir stacklerin top bilgisi için dizi - top
> * bir de stacklerin top index sırası için bir dizi - next
> 
> dizileri oluşturdum. 
> free degiskeni dizinin bos son indexini tutar. Bu sayede islem yapılacak next indexi belirlenmis olur.
> Bu sayede next'in simdiki indisine stack'in top degiskeni atanir. boylece her stack'in top indis bilgisi next icerisinde geriye dogru haritalanmis olur.
> Push yaparken de bu next dizisinde ilgili stackin top indisine bakilarak geriye gidilir.
> 
