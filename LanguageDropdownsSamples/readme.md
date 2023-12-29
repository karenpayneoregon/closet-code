# About

Example to populate a select with languages setup w/o jQuery but has jQuery code commented out.

button get current value

```javascript
document.getElementById("getButton").addEventListener("click", function () {
    var value = document.getElementById("spoken_language").value;
});
```

document ready in short, loads languages to a select, selects English as default and triggers the change event for the select.

```javascript
var selectElement = document.getElementById('spoken_language');
spokenLanguageList()
    .map(item => selectElement.appendChild(new Option(item.name, item.code))
        .cloneNode(true));
selectElement.value = 'en';
selectElement.dispatchEvent(new Event("change"));
```