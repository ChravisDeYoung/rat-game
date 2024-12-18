import { faArrowRight, faX } from "@fortawesome/free-solid-svg-icons";
import { useState } from "react";

import { CircleIconButton } from "../components/CircleIconButton";
import { RatEars } from "../components/RatEars";
import { RatBody } from "../components/RatBody";

const instructions = [
  "each screen will present three cue words that are linked by a fourth word, which is the correct answer",
  "the ear color of the RAT represents the difficulty of that remote association test",
  "if a question is too hard, you can skip it by clicking on the RAT's tail or by pressing the right arrow key on your keyboard",
  "every time you answer a test correctly, you will get points and some time added to the clock - the harder the test, the more points you get",
];

function HowToPage() {
  const [page, setPage] = useState<number>(0);
  const [color, setColor] = useState<string>("bg-difficulty-very-easy");
  const [pointValue, setPointValue] = useState<number>(1);

  // const words = ["cottage", "swiss", "cake"];

  return (
    <>
      <header>
        {page === instructions.length - 1 ? (
          // on the last page
          <CircleIconButton
            faIcon={faX}
            redirectPath="/"
            className="absolute right-3 top-3"
            dataCy="home-link"
          />
        ) : (
          <CircleIconButton
            faIcon={faArrowRight}
            onClick={() => setPage(page + 1)}
            className="absolute right-3 top-3"
            dataCy="next-link"
          />
        )}

        <h1 className="font-bold text-big tracking-widest mt-20">how to</h1>
      </header>

      <section className="flex flex-col items-center">
        <p className="text-medium w-3/4 font-bold">{instructions[page]}</p>
      </section>

      {page === 3 ? (
        <>
          <div className="w-full">
            <button
              className="bg-difficulty-very-easy my-[0.1rem] text-small w-2/3 max-w-sm mx-auto"
              onClick={() => {
                setColor("bg-difficulty-very-easy");
                setPointValue(1);
              }}
            >
              <span className="bg-black h-full block m-auto py-2 w-1/2 text-yellow">
                very easy
              </span>
            </button>

            <button
              className="bg-difficulty-easy my-[0.1rem] text-small w-2/3 max-w-sm mx-auto"
              onClick={() => {
                setColor("bg-difficulty-easy");
                setPointValue(2);
              }}
            >
              <span className="bg-black h-full block m-auto py-2 w-1/2 text-yellow">
                easy
              </span>
            </button>

            <button
              className="bg-difficulty-medium my-[0.1rem] text-small w-2/3 max-w-sm mx-auto"
              onClick={() => {
                setColor("bg-difficulty-medium");
                setPointValue(3);
              }}
            >
              <span className="bg-black h-full block m-auto py-2 w-1/2 text-yellow">
                medium
              </span>
            </button>

            <button
              className="bg-difficulty-hard my-[0.1rem] text-small w-2/3 max-w-sm mx-auto"
              onClick={() => {
                setColor("bg-difficulty-hard");
                setPointValue(4);
              }}
              data-cy="difficulty-hard-btn"
            >
              <span className="bg-black h-full block m-auto py-2 w-1/2 text-yellow">
                hard
              </span>
            </button>

            <button
              className="bg-difficulty-very-hard my-[0.1rem] text-small w-2/3 max-w-sm mx-auto"
              onClick={() => {
                setColor("bg-difficulty-very-hard");
                setPointValue(5);
              }}
            >
              <span className="bg-black h-full block m-auto py-2 w-1/2 text-yellow">
                very hard
              </span>
            </button>
          </div>

          <div className="w-full">
            {/* Ears */}
            <div className="flex w-4/5 max-w-sm relative top-5 justify-between mx-auto">
              <div className="bg-gray rounded-tl-full rounded-tr-full rounded-bl-full h-24 w-24 inline-flex justify-center items-center">
                <div
                  className={`h-12 w-12 rounded-tl-full rounded-tr-full rounded-bl-full mt-3 ml-1 ${color}`}
                  data-cy="left-ear"
                ></div>
              </div>
              <div className="bg-gray rounded-tl-full rounded-tr-full rounded-br-full h-24 w-24 inline-flex justify-center items-center">
                <div
                  className={`h-12 w-12 rounded-tl-full rounded-tr-full rounded-br-full mt-3 mr-1 ${color}`}
                  data-cy="right-ear"
                ></div>
              </div>
            </div>

            {/* Body */}
            <p className="bg-gray py-2 text-medium first:rounded-t-2xl w-2/3 max-w-xs mx-auto mb-5">
              {pointValue} point{pointValue > 1 && "s"}
            </p>
          </div>
        </>
      ) : (
        <>
          <div className="flex flex-col items-center">
            <div className={`w-full ${page === 2 && "opacity-40"}`}>
              <RatEars
                className={`mx-auto ${page === 0 && "opacity-40"}`}
                color="#FF9B9B"
              />

              <RatBody
                className={`mx-auto ${page === 1 && "opacity-40"}`}
                words={["cottage", "swiss", "cake"]}
              />
            </div>

            {/* Answer */}
            <div
              className={`mt-5 w-2/3 max-w-xs ${
                page === 0 || page === 3 || "opacity-40"
              }`}
            >
              <p className="w-full py-2 text-center border-2 border-gray-dark text-medium bg-gray rounded-b-2xl">
                cheese
              </p>
            </div>

            {/* Skip */}
            <button
              className={`bg-pink max-w-xs active:bg-pink-dark lg:hover:bg-pink-dark border-2 border-b-4 border-pink-dark rounded-2xl py-1 mt-2 w-2/3 text-center text-small ${
                page === 2 || page === 3 || "opacity-40"
              }`}
              disabled
            >
              skip
            </button>
          </div>
          <div>&nbsp;</div>
        </>
      )}
    </>
  );
}

export default HowToPage;
