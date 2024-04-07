const { test, expect } = require("@playwright/test");

// test("Is /All Books/ link visible?", async ({ page }) => {
//   await page.goto("http://localhost:3000");
//   const button = await page.$('a[href="/catalog"]');
//   const isLinkVisible = await button.isVisible();

//   expect(isLinkVisible).toBe(true);
// });

// test("IS /Login/ button visible", async ({ page }) => {
//   await page.goto("http://localhost:3000");
//   const button = await page.$('a[href="/login"]');
//   const isBtnVisible = await button.isVisible();

//   expect(isBtnVisible).toBe(true);
// });

// test("Is /Register/ button visible", async ({ page }) => {
//   await page.goto("http://localhost:3000");
//   const button = await page.$('a[href="/register"]');
//   const isButtonVisible = await button.isVisible();

//   expect(isButtonVisible).toBe(true);
// });

// test("is /All Books/ button visible after logging in", async ({ page }) => {
//   await page.goto("http://localhost:3000/login");
//   await page.fill("#email", "aaa@aaa.com");
//   await page.fill("#password", "aaaa");
//   await page.click("input.button.submit");

//   const button = await page.$('a[href="/catalog"]');
//   const isLinkVisible = await button.isVisible();

//   expect(isLinkVisible).toBe(true);
// });

// test("Is /My Books/ visible after logging in", async ({ page }) => {
//   await page.goto("http://localhost:3000/login");
//   await page.fill("#email", "aaa@aaa.com");
//   await page.fill("#password", "aaaa");
//   await page.click("input.button.submit");

//   const button = await page.$('a[href="/profile"]');
//   const isBtnVisible = await button.isVisible();

//   expect(isBtnVisible).toBe(true);
// });

// test("Is users email visible after logging in", async ({ page }) => {
//   await page.goto("http://localhost:3000/login");
//   await page.fill("#email", "aaa@aaa.com");
//   await page.fill("#password", "aaaa");
//   await page.click("input.button.submit");

//   const email = await page.$("#user span");
//   const isEmailVisible = await email.isVisible();

//   expect(isEmailVisible).toBe(true);
// });

// test("Is user able to log in with correct credentials", async ({ page }) => {
//   await page.goto("http://localhost:3000/login");
//   await page.fill("#email", "aaa@aaa.com");
//   await page.fill("#password", "aaaa");
//   await page.click("input.button.submit");

//   await page.$('a[href="/catalog"]');
//   const pageUrl = await page.url();
//   expect(pageUrl).toBe("http://localhost:3000/catalog");
// });

// test("Is user able to log in with empty credentials", async ({ page }) => {
//   await page.goto("http://localhost:3000/login");
//   await page.click("input.button.submit");

//   page.on("dialog", async (dialog) => {
//     expect(dialog.type()).toContain("alert");
//     expect(dialog.message()).toContain("All fields are required!");
//     await dialog.accept();
//   });

//   await page.$('a[href="/login"]');
//   const pageUrl = await page.url();
//   expect(pageUrl).toBe("http://localhost:3000/login");
// });
// test("Is user able to log in with empty email", async ({ page }) => {
//   await page.goto("http://localhost:3000/login");
//   await page.fill("#email", "aaa@aaa.com");
//   await page.click("input.button.submit");

//   page.on("dialog", async (dialog) => {
//     expect(dialog.type()).toContain("alert");
//     expect(dialog.message()).toContain("All fields are required!");
//     await dialog.accept();
//   });

//   await page.$('a[href="/login"]');
//   const pageUrl = await page.url();
//   expect(pageUrl).toBe("http://localhost:3000/login");
// });
// test("Is user able to log in with empty password", async ({ page }) => {
//   await page.goto("http://localhost:3000/login");
//   await page.fill("#password", "aaaa");
//   await page.click("input.button.submit");

//   page.on("dialog", async (dialog) => {
//     expect(dialog.type()).toContain("alert");
//     expect(dialog.message()).toContain("All fields are required!");
//     await dialog.accept();
//   });

//   await page.$('a[href="/login"]');
//   const pageUrl = await page.url();
//   expect(pageUrl).toBe("http://localhost:3000/login");
// });

// test("Is user able to register in with correct credentials", async ({
//   page,
// }) => {
//   await page.goto("http://localhost:3000/register");
//   await page.fill("#email", "bbbbdbd" + getRandomNumber() + "@bbb.bbb");
//   await page.fill("#password", "bbbb");
//   await page.fill("#repeat-pass", "bbbb");
//   await page.click("input.button.submit");

//   await page.waitForURL("**/catalog");
//   const pageUrl = await page.url();
//   expect(pageUrl).toBe("http://localhost:3000/catalog");
// });

// test("Is user able to register in with empty credentials", async ({ page }) => {
//   await page.goto("http://localhost:3000/register");
//   await page.click("input.button.submit");

//   page.on("dialog", async (dialog) => {
//     expect(dialog.type()).toContain("alert");
//     expect(dialog.message()).toContain("All fields are required!");
//     await dialog.accept();
//   });

//   await page.waitForURL("**/register");
//   const pageUrl = await page.url();
//   expect(pageUrl).toBe("http://localhost:3000/register");
// });

// test("Is user able to register in with empty pass", async ({ page }) => {
//   await page.goto("http://localhost:3000/register");
//   await page.fill("#email", "bbbbdbd" + getRandomNumber() + "@bbb.bbb");
//   await page.fill("#repeat-pass", "bbbb");
//   await page.click("input.button.submit");

//   page.on("dialog", async (dialog) => {
//     expect(dialog.type()).toContain("alert");
//     expect(dialog.message()).toContain("All fields are required!");
//     await dialog.accept();
//   });

//   await page.waitForURL("**/register");
//   const pageUrl = await page.url();
//   expect(pageUrl).toBe("http://localhost:3000/register");
// });

// test("Is user able to register in with empty email", async ({ page }) => {
//   await page.goto("http://localhost:3000/register");
//   await page.fill("#password", "bbbb");
//   await page.fill("#repeat-pass", "bbbb");

//   await page.click("input.button.submit");

//   page.on("dialog", async (dialog) => {
//     expect(dialog.type()).toContain("alert");
//     expect(dialog.message()).toContain("All fields are required!");
//     await dialog.accept();
//   });
// });

// test("Is user able to register in with empty repeat pass", async ({ page }) => {
//   await page.goto("http://localhost:3000/register");
//   await page.fill("#password", "bbbb");
//   await page.fill("#email", "bbbbdbd" + getRandomNumber() + "@bbb.bbb");

//   await page.click("input.button.submit");

//   page.on("dialog", async (dialog) => {
//     expect(dialog.type()).toContain("alert");
//     expect(dialog.message()).toContain("All fields are required!");
//     await dialog.accept();
//   });

//   await page.waitForURL("**/register");
//   const pageUrl = await page.url();
//   expect(pageUrl).toBe("http://localhost:3000/register");
// });
// test("Is user able to register in with diffrent repeat pass", async ({ page }) => {
//   await page.goto("http://localhost:3000/register");
//   await page.fill("#password", "bbbb");
//   await page.fill("#password", "bbbab");
//   await page.fill("#email", "bbbbdbd" + getRandomNumber() + "@bbb.bbb");

//   await page.click("input.button.submit");

//   page.on("dialog", async (dialog) => {
//     expect(dialog.type()).toContain("alert");
//     expect(dialog.message()).toContain("Passwords don't match!");
//     await dialog.accept();
//   });

//   await page.waitForURL("**/register");
//   const pageUrl = await page.url();
//   expect(pageUrl).toBe("http://localhost:3000/register");
// });

test('Is a logged in user able to add a book with correct values', async({page})=>{
    await page.goto("http://localhost:3000/login");

    await page.fill("#email", "aaa@aaa.com");
    await page.fill("#password", "aaaa");
    await page.click("input.button.submit");

    await page.waitForURL('http://localhost:3000/catalog');

    await page.click('a[href="/create"]');
    await page.fill("#title", "Book #"+getRandomNumber());
    await page.fill("#description", "From the moment i understood the weakness of my flesh it disgusted me. I craved the certainty and strenght of steel. Your kind cling to your biomass as if it will not decay and fail you. You will come to my kind to be saved but i am already saved")
    await page.fill("#image", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/72/Placeholder_book.svg/1200px-Placeholder_book.svg.png");
   await page.selectOption('#type', 'Fiction');
   
   await page.click('input.button.submit');

   await page.waitForURL("http://localhost:3000/catalog");
   expect(page.url()).toBe("http://localhost:3000/catalog");
})
function getRandomNumber() {
  const min = 100000;
  const max = 999999;
  return Math.floor(Math.random() * (max - min)) + min;
}
