import Image from "next/image";
import { notoSansMono } from './ui/fonts';
import SideNav from './ui/sidenav';

export default function Home() {
  return (
    <div className="flex h-full flex-col py-4 md:px-5">
      <header className="mb-2 flex h-20 items-end justify-start rounded-md bg-orange-600 p-4 md:h-40">
      </header>
      <main className={`${notoSansMono.className} text-gray-300 flex min-h-screen flex-col p-5`}>
        Ding dong, bing bong.
      </main>

      <footer>
        <h2>This is the footer.</h2>
      </footer>
    </div>
  );
}
