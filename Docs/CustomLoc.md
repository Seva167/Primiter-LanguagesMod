# Creating custom localization
### 1. Dumping localization
We will have a starting point for our localization

Open debug menu and press "Dump localization" button

Dump will be saved to `Documents\Primitier\Localizations\Dumps\<locale code>.json`

<sub>Example: `C:\Users\User\Documents\Primitier\Localizations\Dumps\en.json`</sub>

This will be you template for translating the game
### 2. Making localization
The localization file is in json format. You can use your favourite editor (i use Notepad++)

You have the localization name that will be displayed in selector:
```json
"Name": "English"
```
Change it to your language name:
```json
"Name": "<non english language name>"
```
Then there is a dictionary section:
```json
"Dictionary": {
    "MESSAGE_LOADING_AVATAR": "Loading your avatar",
    "MESSAGE_AVATAR_LOAD_FAILED": "Failed to load your avatar",
}
```
Translate every field from English (or Japanese) to your language
### 3. Saving file
Save your file and rename it to `<your language code>.json`
### 4. Publishing localization
Upload your file to somewhere, but i recomend creating a github repository for your localization

**Tell me about your localization so that i can put it on mod's readme page**
- In case of non github send me link somehow
- In case of github repo you can make a pull request on README.md and add your localization there

## Congratulations! You created your own custom localization
