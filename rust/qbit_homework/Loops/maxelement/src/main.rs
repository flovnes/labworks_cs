use std::io;
fn main() {
    println!("{}", solution());
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}

fn solution() -> i16 {
    let mut max_element = i16::MIN;
    loop {
        let num: i16 = input_line().trim().parse().unwrap();
        if num == 0 {break}
        if num > max_element { 
            max_element = num;
        }
    }
    max_element
}