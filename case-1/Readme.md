# Permütasyon

1. Bize öyle bi method / fonksiyon hazırlayın ki, almış olduğu iki yazı (string) parametresini
ölçüp birinin herhangi bir permutasyonunun diğerinin içinde olup olmadığının mantıksal
(boolean) karşılığını bize dönsün.

### Örnek

```json
“baba” , “abab” => true
“baba”, “abc” => false
“lds”, “loodos” => true
```

> İkinci örnek sayesinde anladığım,  burada istenilen permütasyon işlemi *seçmeli sıralama* değil de sadece *sıralama* şeklinde ve P(n,n) isteniyor. Örneğin 2. örnekteki "baba"nın p(4,2)= "ab" olabilir ve "abc" içerisinde var demektir ve doğru olması gerekir ama 2. örnek **false** olduğu için P(n,n) olmalı. Bu durumda da çözüm için uzun uzun permütasyon hesaplatmadan sadece bir string'in tüm elemanlarının diğerinde olup olmadığı kontrol ederek çözülebilir.
