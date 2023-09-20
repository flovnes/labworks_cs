use std::io;

fn main() {
    let sides = input_values();
    let bisectors = solution((sides.0, sides.1, sides.2));

    println!("{}", bisectors.0);
    println!("{}", bisectors.1);
    println!("{}", bisectors.2);
}

fn input_values() -> (f32, f32, f32) {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    let values: Vec<f32> = input_line
    .split_whitespace()
        .map(|q| q.parse().unwrap())
        .collect();
    (values[0], values[1], values[2],)
}

fn solution(sides: (f32, f32, f32)) -> (f32, f32, f32) {
    let (a,b,c) = sides;
    let p: f32 = (a+b+c)/2.;
    
    let bisector_a: f32 = 2.*(b*c*p*(p-a)).sqrt()/(b+c);
    let bisector_b: f32 = 2.*(a*c*p*(p-b)).sqrt()/(a+c);
    let bisector_c: f32 = 2.*(a*b*p*(p-c)).sqrt()/(a+b);

    ((bisector_a),(bisector_b),(bisector_c))
}