function solve(inputArr) {
  class music {
    constructor(typeList, name, time) {
      this.typeList = typeList;
      this.name = name;
      this.time = time;
    }
  }

  let nIterations = parseInt(inputArr.shift());
  let songs = [];
  let type = inputArr[nIterations];
  for (let i = 0; i < nIterations; i++) {
    let currSong = inputArr[i].split("_");
    let song = new music(currSong[0], currSong[1], currSong[2]);
    songs.push(song);
  }

  if (type != "all") {
    songs = songs.filter((s) => s.typeList == type);
  }

  songs.forEach((song) => {
    console.log(song.name);
  });
}

solve([2, "like_Replay_3:15", "ban_Photoshop_3:48", "all"]);
