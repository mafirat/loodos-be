def check(first, second):
    """
    check first string in second string
    """
    for i in first:
        if i not in second or first.count(i) > second.count(i):
            return False
    return True


def compareAndCheck(word, secondWord):
    """
    Compare strings to determine which is short, and check it in the other one.
    """
    return check(word, secondWord) if len(word) <= len(secondWord) else check(secondWord, word)


def sampleApp():
    """
    Sample App
    """
    preDefinedWords = [["baba", "abab"], ["baba", "abc"], ["lds", "loodos"], ["tarif", "mafirat"]]
    for words in preDefinedWords:
        print(words[0], "-", words[1], "=>",
              compareAndCheck(words[0], words[1]))

    print("="*15)

    flag = True
    firstWord, secondWord = "", ""
    while flag:
        print("Try your words! Enter a word")
        firstWord = input()
        if firstWord == ".exit":
            flag = False
            break

        print("Enter the second word")
        secondWord = input()
        print(firstWord, "-", secondWord, "=>",
              compareAndCheck(firstWord, secondWord))

        print("-"*15)


if __name__ == "__main__":
    try:
        sampleApp()
    except KeyboardInterrupt:
        print("\n\t bye-bye")
