# `Xamarin Forms - Material Design Cards`

This repository contains an implementation of Google [material design cards](https://material.io/guidelines/components/cards.html).

# `Summary`
1. [How it looks](#how-it-looks)
2. [Bindable properties](#bindable-properties)
3. [How to use](#how-to-use)
4. [Author](#author)

# `How It Looks`

## On iOS (iPhone SE simulator)

![screenshot](https://raw.githubusercontent.com/xamarin/xamarin-forms-samples/master/WorkingWithImages/Screenshot/Images-sml.png "ios-1")
![screenshot](https://raw.githubusercontent.com/xamarin/xamarin-forms-samples/master/WorkingWithImages/Screenshot/Images-sml.png "ios-2")

## On Android (Nexus 5X real device)

![screenshot](https://raw.githubusercontent.com/xamarin/xamarin-forms-samples/master/WorkingWithImages/Screenshot/Images-sml.png "android-1")
![screenshot](https://raw.githubusercontent.com/xamarin/xamarin-forms-samples/master/WorkingWithImages/Screenshot/Images-sml.png "android-2")

# `Bindable Properties`

* __Title__ (string) : title of the card (on top of it)
* __SubTitle__ (string) : subtitle of the card
* __MainContent__ (View) : Main content wich is supposed to be View (such as a Grid, Label, Image, StackLayout...)
* __PrimaryActionText__ (string) : Text of the first action button at the bottom of the card
* __PrimaryAction__ (ICommand) : command associated with the first action button
* __SecondaryActionText__ (string) : Text of the second action button at the bottom of the card
* __SecondaryAction__ (ICommand) : command associated with the second action button

# `How To Use`

## Create the card component

* 1. Copy-paste the TwoActionsCard component from __Custom Material Cards__ folder
* 2. Make sure to __change the name the namespace__ of the component to match your project & namespace

## Use the component

1. Mention your namespace in the page you want to display cards :

```xml
<ContentPage xmlns:local="clr-namespace:MaterialDesignCards.CustomMaterialCards"/>
```

2. Add a simple card :

```xml
<local:TwoActionsCard Title="your title" SubTitle="your subtitle" PrimaryActionText="ACTION 1" SecondaryActionText="ACTION 2"/>
```

3. A `MainContent` __bindable property__ can be used to insert content such as Label, Grid, StackLayout... on the card

```xml
<local:TwoActionsCard Title="your title" SubTitle="your subtitle" PrimaryActionText="ACTION 1" SecondaryActionText="ACTION 2">
    <local:TwoActionsCard.MainContent>
        <Label Text="This is the main content of the card. It can contain any View element such as a Grid, Label, Image, StackLayout..." FontSize="Small" />
    </local:TwoActionsCard.MainContent>
</local:TwoActionsCard>
```

```xml
<local:TwoActionsCard Title="your title" SubTitle="your subtitle" PrimaryActionText="ACTION 1" SecondaryActionText="ACTION 2">
    <local:TwoActionsCard.MainContent>
        <StackLayout Orientation="Vertical">
            <Label Text=""/>
            <Entry />
            <Image Source=""/>
            <Picker />
        </StackLayout>
    </local:TwoActionsCard.MainContent>
</local:TwoActionsCard>
```

# `Author`

Denis Allard