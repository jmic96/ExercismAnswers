"""Functions to help play and score a game of blackjack.

How to play blackjack:    https://bicyclecards.com/how-to-play/blackjack/
"Standard" playing cards: https://en.wikipedia.org/wiki/Standard_52-card_deck
"""


def value_of_card(card):
    if card in ("J", "Q", "K"):
        return 10
    elif card == "A":
        return 1
    else:
        return int(card)


def higher_card(card_one, card_two):
    if value_of_card(card_one) == value_of_card(card_two):
        return card_one, card_two
    elif value_of_card(card_one) > value_of_card(card_two):
        return card_one
    else:
        return card_two


def value_of_ace(card_one, card_two):
    if card_one == "A":
        return 1
    if card_two == "A":
        return 1

    hand_value = value_of_card(card_one) + value_of_card(card_two)

    if hand_value + 11 > 21:
        return 1
    return 11



def is_blackjack(card_one, card_two):
    if card_one == "A":
        if card_two == "10" or card_two == "J" or card_two == "Q" or card_two == "K":
            return True
        return False

    if card_two == "A":
        if card_one == "10" or card_one == "J" or card_one == "Q" or card_one == "K":
            return True
        return False

    return False


def can_split_pairs(card_one, card_two):
    return value_of_card(card_one) == value_of_card(card_two)

def can_double_down(card_one, card_two):
    return 8 < value_of_card(card_one) + value_of_card(card_two) < 12
