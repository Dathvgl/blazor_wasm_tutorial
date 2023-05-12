var menuChapter = (event) => {
  const menu = document.getElementById("menu-chapter");
  const menuSelect = document.getElementById("menu-chapter-select");

  let check = false;
  const target = event.target;

  if (menu == target || menuSelect == target) check = true;
  for (const item of menu.children) {
    if (check) break;
    if (item == target) check = true;
  }

  if (!check) {
    if (menu.style.display == "grid") {
      menu.style.display = "none";
    } else menu.style.display = "grid";
  }
};

var updateChapter = () => {};

function ImageUrl(helper, link) {
  let aspect = false;
  const image = new Image();

  image.src = link;
  image.onload = async () => {
    const { width, height } = image;
    if (width > height) aspect = true;
    await helper.invokeMethodAsync("ImageUrlAspect", aspect);
  };
}

function AddUpdateChapter(helper) {
  updateChapter = async (event) => {
    try {
      await helper.invokeMethodAsync("KeyboardEvent", event.key);
    } catch (e) {
      console.log(`Error invoke ${e}`);
    }
  };

  window.addEventListener("mouseup", menuChapter);
  window.addEventListener("keyup", updateChapter);
}

function RemoveUpdateChapter() {
  window.removeEventListener("mouseup", menuChapter);
  window.removeEventListener("keyup", updateChapter);
  updateChapter = () => {};
}
