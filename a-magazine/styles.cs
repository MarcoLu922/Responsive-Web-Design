*,
::before,
::after {
  padding: 0;
  margin: 0;
  box-sizing: border-box;
}

html {
  font-size: 62.5%;
}

body {
  font-family: 'Baskervville', serif;
  color: linen;
  background-color: rgb(20, 30, 40);
}

h1 {
  font-family: 'Anton', sans-serif;
}

h2, h3, h4, h5, h6 {
  font-family: 'Raleway', sans-serif;
}

a {
  text-decoration: none;
  color: linen;
}

main {
  display: grid;
  grid-template-columns: minmax(2rem, 1fr) minmax(min-content, 94rem) minmax(2rem, 1fr);
  row-gap: 3rem;
}

img {
  width: 100%;
  object-fit: cover;
}

hr {
  margin: 1.5rem 0;
  border: 1px solid rgba(120, 120, 120, 0.6);
}

.heading {
  grid-column: 2 / 3;
  display: grid;
  grid-template-columns: repeat(2, 1fr);
  row-gap: 1.5rem;
}

.text {
  grid-column: 2 / 3;
  font-size: 1.8rem;
  letter-spacing: 0.6px;
  column-width: 25rem;
  text-align: justify;
}

.hero {
  grid-column: 1 / -1;
  position: relative;
}

.hero-title {
  text-align: center;
  color: orangered;
  font-size: 8rem;
}

.hero-subtitle {
  font-size: 2.4rem;
  color: orangered;
  text-align: center;
}

.author {
  font-size: 2rem;
  font-family: "Raleway", sans-serif;
}

.author-name a:hover {
  background-color: #306203;
}

.publish-date {
  color: rgba(255, 255, 255, 0.5);
}

.social-icons {
  display: grid;
  font-size: 3rem;
  grid-template-columns: repeat(5, 1fr);
  grid-auto-flow: column;
  grid-auto-columns: 1fr;
  align-items: center;
}

.first-paragraph::first-letter {
  font-size: 6rem;
  color: orangered;
  float: left;
  margin-right: 1rem;
}

.quote {
  color: #00beef;
  font-size: 2.4rem;
  text-align: center;
  font-family: "Raleway", sans-serif;
}

.quote::before {
  content: '" ';
}

.quote::after {
  content: ' "';
}

.text-with-images {
  display: grid;
  grid-template-columns: 1fr 2fr;
  column-gap: 3rem;
  margin-bottom: 3rem;
}

.lists {
  list-style-type: none;
  margin-top: 2rem;
}

.lists li {
  margin-bottom: 1.5rem;
}

.list-title, .list-subtitle {
  color: #00beef;
}

.image-wrapper {
  display: grid;
  grid-template-columns: 2fr 1fr;
  grid-template-rows: repeat(3, min-content);
  gap: 2rem;
  place-items: center;
}

.image-1, .image-3 {
  grid-column: 1 / -1;
}

@media only screen and (max-width: 720px) {
  .image-wrapper {
    grid-template-columns: 1fr;
  }
}

@media only screen and (max-width: 600px) {
  .text-with-images {
    grid-template-columns: 1fr;
  }
}

@media only screen and (max-width: 550px) {
  .hero-title {
    font-size: 6rem;
  }

  .hero-subtitle,
  .author,
  .quote,
  .list-title {
    font-size: 1.8rem;
  }

  .social-icons {
    font-size: 2rem;
  }

  .text {
    font-size: 1.6rem;
  } 
}

@media only screen and (max-width:420px){
  .hero-title{
    font-size:4.5rem;
  }
}