function attachEvents() {
  const basrUrlPosts = "http://localhost:3030/jsonstore/blog/posts";
  const baseUrlComments = "http://localhost:3030/jsonstore/blog/comments";

  const loadPostsBtn = document.getElementById("btnLoadPosts");
  const viewBtn = document.getElementById("btnViewPost");
  const postsDiv = document.getElementById("posts");

  let selectedPost = null;
  let posts = {};

  loadPostsBtn.addEventListener("click", async function getAllPosts() {
    const response = await fetch(basrUrlPosts);
    const postsInfo = await response.json();
    const postInfoArr = Object.entries(postsInfo);

    for (const post of postInfoArr) {
      const postKey = post[0];
      const [body, id, title] = Object.values(post[1]);

      let option = document.createElement("option");
      option.value = postKey;
      option.textContent = title;
      postsDiv.appendChild(option);

      posts[postKey] = {
        body,
        id,
        title,
      };
    }
  });

  postsDiv.addEventListener("change", function (event) {
    const selectedOption = event.target.value;
    selectedPost = event.target;
  });

  viewBtn.addEventListener("click", async function GetAllComments() {
    const response = await fetch(baseUrlComments);
    const allCommentsInfo = await response.json();
    const commentInfoArr = Object.entries(allCommentsInfo);

    const postKey = selectedPost.value;
    const post = posts[postKey];

    let postTitle = document.getElementById("post-title");
    postTitle.textContent = post.title;
    let postBody = document.getElementById("post-body");
    postBody.textContent = post.body;

    let postComments = document.getElementById("post-comments");

    while (postComments.firstChild) {
      postComments.removeChild(parentElement.firstChild);
    }

    for (const comment of commentInfoArr) {
      const commentKey = comment[0];
      const [id, postId, text] = Object.values(comment[1]);

      if (post.id == postId) {
        let comment = document.createElement("li");
        comment.id = id;
        comment.textContent = text;

        postComments.appendChild(comment);
      }
    }
  });
}

attachEvents();
