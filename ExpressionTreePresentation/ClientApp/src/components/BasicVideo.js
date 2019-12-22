import React, { Component } from 'react';

export class BasicVideo extends Component {
  static displayName = BasicVideo.name;

  constructor(props) {
    super(props);
    this.state = { videos: [], loading: true };
  }

  componentDidMount() {
    this.populateVideoData();
  }

  static renderVideosTable(videos) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Title</th>
            <th>Channel Title</th>
            <th>Views</th>
            <th>Likes</th>
            <th>Dislikes</th>
            <th>Published</th>
          </tr>
        </thead>
        <tbody>
          {videos.map(video =>
            <tr key={video.id}>
              <td>{video.title}</td>
              <td>{video.channelTitle}</td>
              <td>{video.views}</td>
              <td>{video.likes}</td>
              <td>{video.dislikes}</td>
              <td>{video.publishedAt}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
        : BasicVideo.renderVideosTable(this.state.videos);

    return (
      <div>
        <h1 id="tabelLabel" >Videos</h1>
        {contents}
      </div>
    );
  }

  async populateVideoData() {
    const response = await fetch('video');
    const data = await response.json();
    this.setState({ videos: data, loading: false });
  }
}
