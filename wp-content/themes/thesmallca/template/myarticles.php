<?php /* Template Name: My Articles */ ?>
<?php
get_header();
?>
<main>
    <section class="box-blog">
        <div class="container">
            <div class="title text-center" data-aos="fade-up">
                <h2><?php the_title(); ?> 
	                <span>[
	                	<?php
							$post_counts = wp_count_posts();
							$total_posts = $post_counts->publish;

							echo $total_posts;
							?>
	                ]</span>
	            </h2>
            </div>
            <div class="list-article">
                <div class="row">
                    	<?php
                        $tax = array(
                            'post_type'     => 'post',
                            'orderby'       => 'ID', 
                            'posts_per_page' => 12,
                            'paged'         => get_query_var('paged') ? get_query_var('paged') : 1, 
                        );
                        $looptax = new WP_Query( $tax ); 

                        while ( $looptax->have_posts() ) : $looptax->the_post();
                        ?>
                        <div class="col-md-4" data-aos="fade-up">
                            <div class="item-article">
                                <div class="avarta"><a href="<?php the_permalink(); ?>"><img src="<?= the_post_thumbnail_url(); ?>" class="img-fluid w-100" alt="<?php the_title(); ?>"></a></div>
                                <div class="info">
                                    <div class="date"><?= get_the_date('d/m/Y'); ?></div>
                                    <h3><a href="<?php the_permalink(); ?>"><?php the_title(); ?></a></h3>
                                    <div class="desc">
                                        <?php the_excerpt(); ?>
                                    </div>
                                </div>
                            </div>
                        </div>
                    <?php
                        endwhile;
                        wp_reset_query(); 
                    ?>  
                </div>
            </div>
        </div>
    </section>
</main>     
<?php
get_footer();
?>