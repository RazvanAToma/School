let shoppingItems = [];

let itemInputEl = document.querySelector(".itemInput");
let listEl = document.querySelector("ul");

itemInputEl.addEventListener("keydown", checkFunc);

function checkFunc(e)
{
    if (e.key == "Enter")
        {
        addToShoppingList();
    }
}


function addToShoppingList()
{
    // Create new List element
    let newLi = document.createElement("li");
    newLi.appendChild(document.createTextNode(itemInputEl.value));
    shoppingItems.push(itemInputEl.value);
    
    
    // Event Listeners
    newLi.addEventListener("mouseover", () => {
        newLi.style.textDecoration = "line-through";
        newLi.style.color = "red";
    });
    
    newLi.addEventListener("mouseout", () => {
        newLi.style.textDecoration = "none";
        newLi.style.color = "black";
    });
    
    newLi.addEventListener("click", () => {
        newLi.remove();
        shoppingItems.splice(shoppingItems.indexOf(itemInputEl.value), 1);
    });
    
    
    // Append the list element and reset input field
    listEl.appendChild(newLi);
    
    itemInputEl.value = "";
}