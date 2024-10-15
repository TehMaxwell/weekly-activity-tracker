import Image from "next/image";
import { notoSansMono } from './ui/fonts';

export default function Home() {
  return (
    <>
      <header>
        <Image 
          src='/yorkshireyoda.jpg'
          width={200}
          height={152}
          className="hidden md:block"
          alt="Be reyt it will"
        />
        <h1>I'm starting my own thing now.</h1>
      </header>

      <main className={`${notoSansMono.className} text-gray-300 flex min-h-screen flex-col p-5`}>
        Ding dong, bing bong.
      </main>

      <footer>
        <h2>This is the footer.</h2>
      </footer>
    </>
  );
}
