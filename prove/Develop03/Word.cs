/******************************************************************************
    Class Name:
        Word
    Responsibility:
        This class will represent a single word in the scripture. It will store 
        the word's content and its visibility status.
    Attributes:
        _content: string
        _visible: bool
    Behavior:
        Hide(): void - sets the visibility status to false
        Show(): void - sets the visiblilty status to true
        IsVisible(): bool - returns the visibility status
        ToText(): String - returns the content of the word if visible, or a 
                    placeholder like "___" if not.
    Constructors:
        Word(content: String)
*/

using System;

public class Word {
    private string _content;
    private bool _visible;

    public Word(string content) {
        _content = content;
        _visible = true;
    }

    public void Hide() {
        _visible = false;
    }

    public void Show() {
        _visible = true;
    }

    public bool IsVisible() {
        return _visible;
    }

    public string ToText() {
        if (_visible) {
            return _content;
        } else {
            // display number of underscores equal to the length of the word
            return new String('_', _content.Length);
        }
    }
}