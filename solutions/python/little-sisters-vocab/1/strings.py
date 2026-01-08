"""Functions for creating, transforming, and adding prefixes to strings."""


def add_prefix_un(word):
    return "un" + word

def make_word_groups(vocab_words):
    prefix = vocab_words[0]
    return " :: ".join([prefix] + [prefix + word for word in vocab_words[1:]])


def remove_suffix_ness(word):
    root = word[:-4]

    if root.endswith("i"):
        return root[:-1] + "y"

    return root
    
def adjective_to_verb(sentence, index):
    word = sentence.split()[index]

    if word.endswith("."):
        word = word[:-1]

    return word + "en"

