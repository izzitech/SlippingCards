# SlippingCards

Study smarter with cards. A.K.A. Flash Cards, write a concept on one side and the explanation on the other, then slip it.

You can host this on your own server or [just use it here.](https://cards.izzitech.com.ar/)

![](readme-img/show.gif)

## Characteristics
- Made in ASP.net Core MVC (cause we hate Javascript, lmao).
- Bootstrap 4.
- Database PostgreSQL (not quite yet).

## Roadmap

- [x] Load text cardset and display the cards.
- [ ] Let the user change card emoji.
- [ ] Allow users to create an account and save cardset.
- [ ] Show a card from a specific cardset at random.
- [ ] Create Angular UI.
- [ ] Make PWA.
- [ ] Javascript UI to create cards graphically and rearrange them dynamically.
- [ ] Let users upload pictures for cards.

## How does it work

You can load a text with the folowing format:

``` 
Cardset Title
=============

Section Title
-------------
Card title: Card text.
Another card title: Another card text.
```

There is a template named SlippingCards_template.txt inside this repo.

Hyphens and equal signs should be at least 4 characters.

If you press "Create" button with no text on the field, instructions will be shown.