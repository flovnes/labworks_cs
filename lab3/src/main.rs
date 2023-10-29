use std::io;
fn main() {
    println!("Point A = (0;0)\nEnter point B:");
    let (a,b) = input_values();
    println!("Point B = ({};{})", a, b);
    let (area, point_c) = find_smallest_area((a,b));
    let (x,y) = point_c;
    println!("For B({a};{b}) smallest area is {area:0.01} with C({x};{y})");
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}

fn input_values() -> (i64,i64) {
    let values: Vec<i64> = input_line()
    .split_whitespace()
    .map(|q| q.parse().unwrap())
    .collect();
    (values[0], values[1])
}

fn triangle_area(point_b: (i64, i64), point_c: (i64, i64)) -> f64 {
    let (x_b,y_b) = point_b;
    let (x_c,y_c) = point_c;
    ((x_b*y_c-x_c*y_b) as f64).abs()/2.0
}

fn find_smallest_area(point_b: (i64, i64)) -> (f64, (i64, i64)) {
    let (a,b) = point_b;
    let mut min_area = f64::MAX;
    let mut point_c: (i64, i64) = (0,0);
    let start = 0.min(a).min(b);
    let end = 0.max(a).max(b);
    for x in start..=end/2 {
        let y = (x*b/a).floor()+1;
        let cur_area = triangle_area((a,b), (x,y));
        if min_area > cur_area {
            point_c = (x,y);
            min_area = cur_area;
        }   
    }
    (min_area, point_c)
}