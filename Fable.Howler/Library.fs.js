import { Record, Union } from "../Sample/src/.fable/fable-library.3.2.9/Types.js";
import { record_type, union_type, string_type, bool_type } from "../Sample/src/.fable/fable-library.3.2.9/Reflection.js";

export class preloadOption extends Union {
    constructor(tag, ...fields) {
        super();
        this.tag = (tag | 0);
        this.fields = fields;
    }
    cases() {
        return ["Preload", "Metadata"];
    }
}

export function preloadOption$reflection() {
    return union_type("Fable.Howler.preloadOption", [], preloadOption, () => [[["Item", bool_type]], [["Item", string_type]]]);
}

export class Sprite extends Record {
    constructor(test) {
        super();
        this.test = test;
    }
}

export function Sprite$reflection() {
    return record_type("Fable.Howler.Sprite", [], Sprite, () => [["test", string_type]]);
}

